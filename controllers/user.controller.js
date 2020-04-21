//import userModel from '../models/user'
const userModel = require('../models').User

const register = async (req, res) => {
  try {
    const { firstName, lastName, email, password } = req.body

    console.log(firstName, lastName, email, password)

    const userExist = await userModel.findOne({ where: { email: email } })

    console.log(userExist)

    if (userExist) {
      throw new Error('User already exists')
    } else {
      const user = await userModel.create({
        firstName: firstName,
        lastName: lastName,
        email: email,
        password: password,
      })

      res.status(200).send('User added')
    }
  } catch (error) {
    res.status(409).send(error.message)
  }
}

const login = (req, res) => {
  try {
    const { firstName, lastName, email, password } = req.body
  } catch (error) {
    console.log(error)
  }
}

module.exports = { register, login }
