const express = require('express')
const bodyParser = require('body-parser')
const cors = require('cors')
require('dotenv').config()

const routes = require('./routes/index')

const app = express()
const port = process.env.PORT

app.use(cors())
app.use(bodyParser.json())

app.use(routes)

app.listen(port, () => console.log(`Server started at port ${process.env.PORT}`))
