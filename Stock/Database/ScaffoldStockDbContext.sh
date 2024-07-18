cd ..
dotnet ef dbcontext scaffold DataSource=./Database/StockDatabase.db Microsoft.EntityFrameworkCore.Sqlite --output-dir Models --context StockDbContext --data-annotations --no-pluralize --verbose
cd Database