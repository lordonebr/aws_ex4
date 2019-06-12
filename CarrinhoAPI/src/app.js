
var express = require('express');
var bodyParser = require('body-parser');
var app = express();
const router = express.Router();
//Rotas
const index = require('./routes/index');
const carrinhoRoute = require('./routes/carrinhoRoute');

app.use(bodyParser.urlencoded({ extended: true }))
app.use(bodyParser.json())

app.use('/', index);
app.use('/api/values', carrinhoRoute);

module.exports = app;
