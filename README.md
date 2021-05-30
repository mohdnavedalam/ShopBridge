# ShopBridge

This project is built on .Net Core 3.1 and Visual Studio 2019.

To run the code on your local machine, follow the below steps.

1 - Clone the repository.
2 - Open the solution in Visual Studio 2017 or 2019.
3 - Open the Package Manager Console and run the following command:
	dotnet ef database update --project [full path of the .csproj file].
4 - Run the code and test the APIs with Postman.

The URLs for the APIs are as follows:

Add new Product:

URL - /api/products
Verb - POST

Update Product:

URL - /api/products
Verb - PUT

Delete Product:

URL - /api/products/{id}
Verb - DELETE

Select All Products:

URL - /api/products/getall
Verb - GET