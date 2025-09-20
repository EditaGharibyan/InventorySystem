 It’s a Web API built to manage an inventory system, like what you’d use in a store to keep track of products, categories,and suppliers. The API lets you create, read, update, and delete (CRUD) Products, Categories,
 and Suppliers, with all the fancy database relationships we learned about. Products have a one-to-one (1:1) relationship with ProductDetails (like description and SKU), Categories have a one-to-many (1:N) 
 relationship with Products (one category can have lots of products), and Products have a many-to-many (N:M) relationship with.Suppliers (a product can have multiple suppliers, and a supplier can supply multiple 
 products). I used ASP.NET Core for the backend, Entity Framework Core (EF Core) for database stuff, and SQLite to keep it simple with a local inventory.db file. I added indexes on Product name (to make it unique)
 and CategoryId (for faster queries). The API runs on HTTPS (like https://localhost:7218) and has Swagger for testing endpoints interactively.I hit some bumps, like a “no such table: Products” 
 error, but fixed it with migrations. 
