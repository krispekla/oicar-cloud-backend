import express from 'express'
import swaggerUi from 'swagger-ui-express'
import swaggerDocument from '../utils/swagger'
import * as userController from '../controllers/user.controller'
const router = express.Router()

router.post('/api/user/register', userController.register)
router.post('/api/user/login', userController.login)
router.use('/api/docs', swaggerUi.serve)
router.get('/api/docs', swaggerUi.setup(swaggerDocument))

export default router
