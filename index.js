(function() {
    'use strict';

    const app = {};

    const puppeteer = require('puppeteer');
    const cheerio = require('cheerio');
    const fs = require('fs');
    const http = require('http');

    const config = require('./config');
    const helper = require('./helper');

    let browser = null;
    let page = null;

    let problems = [];

    const init = async() => {
        browser = await puppeteer.launch({
            headless: false,
            slowMo: 500,
        });
        page = await browser.newPage();
        await page.setViewport({
            width: 1024,
            height: 768,
            deviceScaleFactor: 1,
        });

        await getProblems();
        await page.waitFor(config.timeout);
        await scrapeData();
        await page.waitFor(config.timeout);

        await browser.close();
    };

    const getProblems = async() => {
        await page.goto(config.problemsUrl, config.pageNavigationOptions);
        await page.waitFor(config.timeout);

        const option = (await page.$x(
            '//select[@class="form-control"]/option[text() = "all"]'
        ))[0];
        const value = await (await option.getProperty('value')).jsonValue();
        await page.select('select.form-control', value);
        await page.waitFor(config.timeout);

        const bodyHTML = await page.evaluate(() => document.body.innerHTML);
        const $ = cheerio.load(bodyHTML);

        $('div.question-list-table > table > tbody.reactable-data > tr').each(
            (i, element) => {
                problems.push({
                    number: $(element).find('td:nth-child(2)').text(),
                    title: $(element).find('td:nth-child(3) > div > a').text(),
                    url: config.siteUrl + $(element).find('td:nth-child(3) > div > a').attr('href'),
                    difficulty: $(element).find('td:nth-child(6) > span').text(),
                    question: '',
                    code: '',
                });
            }
        );

        const metadata = await helper.readFile(config.metadataFilePath);
        const metadataProblems = JSON.parse(metadata);

        if (metadata.length < problems.length) {
            config.writeFile(config.metadataFilePath, JSON.stringify(problems));
        } else {
            problems = metadataProblems;
        }

        for (let i = 0; i < problems.length; i++) {
            const filePath = config.problemsFolderPath + problems[i].number + '.json';
            const isFilePresent = await config.isFilePresent(filePath);

            if (!isFilePresent) {
                config.writeFile(filePath, JSON.stringify(problems[i]));
            }
        }
    };

    const scrapeData = async() => {
        let isLanguageSelected = false;

        for (let i = 0; i < problems.length; i++) {
            let problem = problems[i];
            const filePath = config.problemsFolderPath + problem.number + '.json';
            const isFilePresent = await config.isFilePresent(filePath);

            if (isFilePresent) {
                const fileData = await helper.readFile(filePath);
                problem = JSON.parse(fileData);
                await helper.deleteFile(filePath);
            }

            if (problem.question == '') {
                await page.goto(problem.url, config.pageNavigationOptions);

                const bodyHTML = await page.evaluate(() => document.body.innerHTML);
                const $ = cheerio.load(bodyHTML);
                await page.waitFor(config.timeout);

                if (!isLanguageSelected) {
                    await page.click('div.ant-select-selection');
                    await page.waitFor(config.timeout);
                    await page.click('li[data-cy="lang-select-C#"]');
                    await page.waitFor(config.timeout);
                    isLanguageSelected = true;
                }

                problem.question = $('div.question-content__JfgR > div').html();

                if (problem.question != null && problem.question.length > 0) {
                    problem.question = problem.question.replace(/<[^>]+>/g, '');
                }

                $('div.CodeMirror-code div').each(function(index, element) {
                    problem.code += $(element).find('pre').text();
                });

                config.writeFile(filePath, JSON.stringify(problem));
                await page.waitFor(config.timeout);
            }
        }
    };

    init();

    module.exports = app;
}());