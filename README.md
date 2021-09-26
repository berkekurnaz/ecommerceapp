# E-Commerce Merchandising Management System
This project contains the e-commerce merchandising management system. The project is developed with .net core and mongodb.

## Installation
- Download this project to your machine.
```bash
https://github.com/berkekurnaz/ecommerceapp.git
```
- Install .net core 3.1 and mongodb <br/>
- Run the project <br/>

## Web Api - Endpoints
Route| Http Verb | Post Body | Açýklama
:--- | :---: | :---: | :---:
/category | `GET` | Empty | Get All Categories
/category| `POST` | CategoryRequestDTO | Create a new category
/category/:id | `DELETE` | Empty | Delete a category

Route| Http Verb | Post Body | Açýklama
:--- | :---: | :---: | :---:
/product | `GET` | Empty | Get All Products
/product/:id | `GET` | Empty | Get a one product by product id
/product | `POST` | ProductRequestDTO | Create a new product
/product/:id | `PUT` | ProductRequestDTO | Update a product
/product/:id | `DELETE` | Empty | Delete a product

- Product Search Example: /product?title=Apple&description=Macbook&min=10&max=125&category=Computer


## Contact
> Developer: Berke Kurnaz

> Mail Address: contact@berkekurnaz.com <br/>

> Github: https://github.com/berkekurnaz
