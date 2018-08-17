const express = require('express');


const init = (data) => {
    const app = express();

    require('./config/config').applyTo(app);
    require('./auth/auth').applyTo(app, data);
    require('./routers/routers').attachTo(app, data);

    return Promise.resolve(app);
}

module.expors = {
    init,
};