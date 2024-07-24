cd ..
dotnet ef dbcontext scaffold DataSource=./Database/PortfolioDatabase.db Microsoft.EntityFrameworkCore.Sqlite --output-dir Models --context PortfolioDbContext --data-annotations --no-pluralize --verbose
cd Database