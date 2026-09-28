using Dapper;
using DemoDapper;
using e_Shop.CoreBusiness.Models;
using System.Data;
using System.Data.SqlClient;

var connectStr = "Data Source=MIU\\MSSQLSERVER01;Initial Catalog=eShop;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

var da = new DataAccess(connectStr);

var results1 = da.Query<Product, dynamic>("SELECT * FROM Product", new { });

var results2 = da.QuerySingle<Product, dynamic>("SELECT * FROM Product WHERE ProductId = @ProductId",
				new { ProductId = "495" });

var sql = "";
//using (IDbConnection conn = new SqlConnection(connectStr))
//{
//	// var sql = "INSERT INTO Product (ProductId, Brand, Name, Price) VALUES (@ProductId, @Brand, @Name, @Price)";
//	// var prod = new Product{ProductId = 1000002,Brand = "His Brand",Name = "His Product",Price = 25.5};
//	// conn.Execute(sql, prod);

//	//var sql = @"UPDATE Product 
//	//			SET ImageLink = @Url
//	//			WHERE Name = @Name";
//	//conn.Execute(sql, new { Url = " http://www/google.com/images", Name = "His Product" });

//	//var sql = @"DELETE FROM Product Where Name = @Name";
//	//conn.Execute(sql, new { Name = "His Product" });

//	//var results = conn.Query<Product>("SELECT * FROM Product");

//	//foreach (var record in results)
//	//{
//	//	Console.WriteLine($"{record.Name}:{record.Price}:{record.ImageLink}");
//	//}

//	// HELEPER/WRAPPER
//}

	

