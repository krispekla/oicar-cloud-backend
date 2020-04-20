//import { register, login } from './controllers/user.controller.js'
const userController = require('../controllers/user.controller')
const express = require('express')
const router = express.Router()

router.post('/user/register', userController.register)
router.post('/user/login', userController.login)

module.exports = router
