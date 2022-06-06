let fs = require('fs')

fs.readFile('C:/TodoSettings/MailAddress.txt','utf-8',(err,data) => {
    var UserMail = data
})

const nodemailer = require('nodemailer')

let transporter = nodemailer.createTransport({
    service: 'gmail',
    auth: {
        user: 'todot590@gmail.com',
        pass: 'dnzrdxbiejknnltc'
    }
})

let mailoptions ={
    from: 'todot590@gmail.com',
    to:'',
    subject: 'Mail testing',
    html: '<h2>Test Content</h2>'
}

transporter.sendMail(mailoptions,(err,data) => {
    if(err) console.log(err)
    else console.log('mail gönderildi')
})