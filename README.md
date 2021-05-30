# ShopBridge

This project is built on .Net Core 3.1 and Visual Studio 2019.</br>

To run the code on your local machine, follow the below steps.</br>

1 - Clone the repository. </br>
2 - Open the solution in Visual Studio 2017 or 2019.</br>
3 - Open the Package Manager Console and run the following command:</br>
	dotnet ef database update --project [full path of the .csproj file].</br>
4 - Run the code and test the APIs with Postman.</br></br>

The URLs for the APIs are as follows:</br></br>

Add new Product:

URL - /api/products</br>
Verb - POST

Update Product:</br></br>

URL - /api/products</br>
Verb - PUT</br></br>

Delete Product:</br></br>

URL - /api/products/{id}</br>
Verb - DELETE</br></br>

Select All Products:</br></br></br>

URL - /api/products/getall</br>
Verb - GET</br></br>
