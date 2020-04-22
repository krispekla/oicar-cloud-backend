import express from 'express'
import bodyParser from 'body-parser'
import cors from 'cors'
import router from './routes/index'

require('dotenv').config()

const app = express()
const port = process.env.PORT

app.use(cors())
app.use(bodyParser.json())
app.use(router)

app.listen(port, () => console.log(`Server started at port ${process.env.PORT}`))
