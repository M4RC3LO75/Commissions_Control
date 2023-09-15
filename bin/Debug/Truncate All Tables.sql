DELETE from tbCommissions;
DELETE from tbPromoProducts;

DELETE from tbCommissionsIndex;
DELETE from tbPromoProductsIndex;

DELETE from tbCommissionsTypes;
DELETE from tbPromoProductsTypes;

DELETE from tbStdValues;
DELETE from tbSuppliers;
GO

DECLARE @MAXComm int SELECT @MAXComm = MAX([idCommission]) FROM[tbCommissions] IF @MAXComm IS NULL SET @MAXComm = 0 DBCC CHECKIDENT('[tbCommissions]', RESEED, @MAXComm);
DECLARE @MAXCommIndex int SELECT @MAXCommIndex = MAX([idCommissionIndex]) FROM[tbCommissionsIndex] IF @MAXCommIndex IS NULL SET @MAXCommIndex = 0 DBCC CHECKIDENT('[tbCommissionsIndex]', RESEED, @MAXCommIndex);
DECLARE @MAXCommTypes int SELECT @MAXCommTypes = MAX([idCommissionType]) FROM[tbCommissionsTypes] IF @MAXCommTypes IS NULL SET @MAXCommTypes = 0 DBCC CHECKIDENT('[tbCommissionsTypes]', RESEED, @MAXCommTypes);

DECLARE @MAXPromoProd int SELECT @MAXPromoProd = MAX([idPromoProduct]) FROM[tbPromoProducts] IF @MAXPromoProd IS NULL SET @MAXPromoProd = 0 DBCC CHECKIDENT('[tbPromoProducts]', RESEED, @MAXPromoProd);
DECLARE @MAXPromoProdIndex int SELECT @MAXPromoProdIndex = MAX([idPromoProductIndex]) FROM[tbPromoProductsIndex] IF @MAXPromoProdIndex IS NULL SET @MAXPromoProdIndex = 0 DBCC CHECKIDENT('[tbPromoProductsIndex]', RESEED, @MAXPromoProdIndex);
DECLARE @MAXPromoProdType int SELECT @MAXPromoProdType = MAX([idPromoProductType]) FROM[tbPromoProductsTypes] IF @MAXPromoProdType IS NULL SET @MAXPromoProdType = 0 DBCC CHECKIDENT('[tbPromoProductsTypes]', RESEED, @MAXPromoProdType);

DECLARE @MAXStdValue int SELECT @MAXStdValue = MAX([idStdValue]) FROM[tbStdValues] IF @MAXStdValue IS NULL SET @MAXStdValue = 0 DBCC CHECKIDENT('[tbStdValues]', RESEED, @MAXStdValue);
DECLARE @MAXSupplier int SELECT @MAXSupplier = MAX([idSupplier]) FROM[tbSuppliers] IF @MAXSupplier IS NULL SET @MAXSupplier = 0 DBCC CHECKIDENT('[tbSuppliers]', RESEED, @MAXSupplier);
GO