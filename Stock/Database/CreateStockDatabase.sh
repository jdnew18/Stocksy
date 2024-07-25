sqlite3 StockDatabase.db < CreateStockDatabase.sql
sqlite3 StockDatabase.db '.mode tabs' '.import StockList.tsv Stock' 'select * from Stock;'
sqlite3 StockDatabase.db '.mode tabs' '.import QuoteList.tsv Quote' 'select * from Quote;'