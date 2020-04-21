const userModel = require('../models').User
const bcrypt = require('bcrypt')
const salt = bcrypt.genSaltSync(10)

const register = async (req, res) => {
  try {
    const { firstName, lastName, email, password } = req.body

    const userExist = await userModel.findOne({ where: { email: email } })

    if (userExist) {
      throw new Error('User already exists')
    } else {
      const passwordHash = bcrypt.hashSync(password, salt)

      const user = await userModel.create({
        firstName: firstName,
        lastName: lastName,
        email: email,
        password: passwordHash,
      })

      res.status(200).send('User added')
    }
  } catch (error) {
    res.send(error.message)
  }
}

const login = async (req, res) => {
  try {
    const { email, password } = req.body

    const userData = await userModel.findOne({
      where: { email: email },
    })

    if (!userData) {
      throw new Error('User not found!')
    }

    const user = userData.toJSON()

    const validPassword = bcrypt.compareSync(password, user.password)

    if (validPassword) {
      res.status(200).send('Success')
    } else {
      throw new Error('Incorrect password or email.')
    }
  } catch (error) {
    res.send(error.message)
  }
}

module.exports = { register, login }
