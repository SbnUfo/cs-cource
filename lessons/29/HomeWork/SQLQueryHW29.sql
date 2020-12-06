WITH AllOrdersWithTotalSum([CustomerId], [Year], [Total Price]) AS 
(SELECT
	Order.CustomerId,
	YEAR(Order.OrderDate),
	SUM(Product.Price * OrderLine.[Count]) * (1 - ISNULL(O.Discount, 0)) AS 'Total Price'
FROM [Order] AS Order
	JOIN [OrderLine] AS OrderLine 
	ON Order.Id = OrderLine.OrderId
	JOIN [Product] AS Product 
	ON OrderLine.ProductId = Product.Id
GROUP BY Order.CustomerId, 
	YEAR(Order.OrderDate),
	Order.Discount),

TotalYearSum([CustomerId], [Year], [YearSum]) AS
(
SELECT
	[CustomerId],
	[Year],
	SUM([Total Price])
FROM AllOrdersWithTotalSum
GROUP BY [Year],
	[CustomerId]
),

MaxTotalYearSum([Year], [YearSum]) AS
(
SELECT
    [Year],
    MAX(YearSum)
FROM TotalYearSum
GROUP BY [Year]
)


SELECT
    MaxTotalYearSum.[Year],
    TotalYearSum.CustomerId,
    Customer.Name,
    MaxTotalYearSum.YearSum
FROM MaxTotalYearSum AS MaxTotalYearSum
	JOIN TotalYearSum AS TotalYearSum 
	ON MaxTotalYearSum.YearSum = TotalYearSum.YearSum
	JOIN [Customer] AS Customer 
	ON TotalYearSum.CustomerId = Customer.Id
