const express = require('express');
const bodyParser = require('body-parser');
const fs = require('fs');

let destStatic = './src/static';
if (fs.existsSync('./build')) {
    destStatic = './build/static';
}

const applyTo = (app) => {
    app.use(bodyParser.json());
    app.use(bodyParser.urlencoded({ extended: true }));
    app.use(express.static(destStatic));
    app.use('/libs', express.static('node_modules'));
};

module.exports = { applyTo };