
SELECT SUM(Cast (DiscountValue as money)) AS 'Income'
FROM [Transaction] 
WHERE [Date] BETWEEN '{0}' AND '{1}'

