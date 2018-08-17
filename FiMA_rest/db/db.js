var sql = require('mssql');

const init = (sqlConfig) => {
    return sql.connect(sqlConfig);
};

module.exports = { init };