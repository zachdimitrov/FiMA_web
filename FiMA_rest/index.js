var express = require('express');
var app = express();
var sql = require('mssql');

var sqlConfig = {
    user: 'fima',
    password: '1coProject',
    server: 'localhost\\SQLEXPRESS',
    database: 'KAROLL_PULSE',
    options: {
        encrypt: false
    }
}

var server = app.listen(8881, function() {
    var host = server.address().address;
    var port = server.address().port;
    console.log(`App listening at http://${host}:${port}`);
});

app.get('/banks', function(req, res) {
    sql.connect(sqlConfig)
        .then(function() {
            var request = new sql.Request();
            request.query('select BANK_NAME from BANKS')
                .then(function(recordset) {
                    console.log(recordset);
                    res.end(JSON.stringify(recordset));
                })
                .catch(function(err) {
                    console.log(err);
                    sql.close();
                })
        })
        .catch(function(err) {
            console.log(err);
        })
})