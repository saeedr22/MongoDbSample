using MongoDB.Bson;
using MongoDB.Driver;
using Services;
using Util;

Print print = new Print();

Insert insert = new Insert();
insert.InsertOneAsync();
insert.InsertManyAsync();

Select select = new Select();
var books = select.GetAll();
print.PrintList<Book>(books);

Console.WriteLine("Filter List : ");
var filterBuilder = Builders<Book>.Filter;
var sortBuilder = Builders<Book>.Sort;
var filter = filterBuilder.Eq("Price", 60000) | filterBuilder.Gte("Price", 700000);
var sort = sortBuilder.Ascending("Title");

var bookSearch = select.Get(filter, sort);
print.PrintList<Book>(bookSearch);

 var updateOpr = Builders<Book>.Update.Set("LastStock", new DateTime().AddDays((-5)));
// var updateFilter = Builders<Book>.Filter.Lte("LastStock", new DateTime().AddDays(-10));

// Update update = new Update();
// update.UpdateOpr(updateFilter, updateOpr);