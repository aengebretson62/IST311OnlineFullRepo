var mysql = require('mysql');

const Joi = require('joi');
const express = require ('express');

const app = express();

app.use(express.json());

app.get('/', (req,res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "root",
        password: "Teach5%%",
        database: "mydb"
      });

    con.connect(function(err) {
        if (err) throw err;
        console.log("Connected to the database!");
      });
    res.send('Connected to the database!');
});

app.get('/api/customers', (req,res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "root",
        password: "Teach5%%",
        database: "mydb"
      }); 

    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM customers", function (err, result, fields) {
          if (err) throw err
          else {
              console.log(result);
              res.send(result); 
          }
        });
      });
});

app.get('/api/customers/:id', (req, res) => {

   let con = mysql.createConnection({
    host: "localhost",
    user: "root",
    password: "Teach5%%",
    database: "mydb"
  });

    con.connect(function(err) {
        if (err) throw err;
        con.query("SELECT * FROM customers WHERE id = " + parseInt(req.params.id), function (err, result) {
          if (err) throw err 
          else {
                console.log(result);
                if (result=="") return res.status(404).send('No customer with that id was found');
                      res.send(result);
          }
        });
      });
})


app.post('/api/customers', (req,res) => {

    let con = mysql.createConnection({
        host: "localhost",
        user: "root",
        password: "Teach5%%",
        database: "mydb"
      });
    
      con.connect(function(err) {
        if (err) throw err;
        else {
            var sql = "INSERT INTO customers (name, address) VALUES ('" + req.body.name + "','" + req.body.address + "')";
            con.query(sql, function (err, result) {
                if (err) throw err;
                else {
                    console.log("1 record inserted");
                    res.send("1 record inserted");
                }    // if err
        });
        } // if err
      });

});

app.put('/api/customers/:id', (req,res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "root",
        password: "Teach5%%",
        database: "mydb"
      });
    
        con.connect(function(err) {
            if (err) throw err;
            con.query("SELECT * FROM customers WHERE id = " + parseInt(req.params.id), function (err, result) {
              if (err) throw err 
              else {
                    console.log(result);
                    if (result=="") return res.status(404).send('No customer with that id was found');
                    else {
                        var sql = "UPDATE customers SET name = '" + req.body.name + "', address = '" + req.body.address + "' WHERE id = " + parseInt(req.params.id);
                        con.query(sql, function (err, result) {
                          if (err) throw err;
                          console.log(" Record updated!");
                          res.send("Record updated!")
                        });
                    } // if result
              }  // if err
            });
          });
});


app.delete('/api/customers/:id', (req, res) => {
    let con = mysql.createConnection({
        host: "localhost",
        user: "root",
        password: "Teach5%%",
        database: "mydb"
      });
    
        con.connect(function(err) {
            if (err) throw err;
            con.query("SELECT * FROM customers WHERE id = " + parseInt(req.params.id), function (err, result) {
              if (err) throw err 
              else {
                    console.log(result);
                    if (result=="") return res.status(404).send('No customer with that id was found');
                    else {
                        var sql = "DELETE FROM customers WHERE id = " + parseInt(req.params.id);
                        con.query(sql, function (err, result) {
                          if (err) throw err;
                          console.log(" Record deleted!");
                          res.send("Record deleted!")
                        });
                    } // if result
              }  // if err
            });
          });
});


const port = process.env.PORT || 3000;
app.listen(port, () => console.log(`Listening on port ${port}...`));