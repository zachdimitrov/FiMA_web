/* globals process */
/* eslint-disable no-process-env */

const port = process.env.PORT || 5001;
const server = 'localhost\\SQLEXPRESS';

var sqlConfig = {
    user: 'fima',
    password: '1coProject',
    server: server,
    database: 'KAROLL_PULSE',
    options: {
        encrypt: false
    }
}

module.exports = { port, sqlConfig };