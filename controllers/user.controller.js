//import userModel from '../models/user'
const userModel = require('../models/user').User

const register = async (req, res) => {
  try {
    const { firstName, lastName, email, password } = req.body

    console.log(firstName, lastName, email, password)

    const resultExist = await userModel.findOne({ where: { email: email } })

    if (resultExist) throw new Error(409, 'User already exists')

    const resultUser = await userModel.create({
      firstName: firstName,
      lastName: lastName,
      email: email,
      password: password,
    })

    res.send(resultUser)
    console.log('result: ', resultUser)
  } catch (error) {
    throw new Error(409, error.message)
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
