SELECT SUM(Cast (TotalValue as money)) AS 'Expenses' 
FROM [Transaction] 
WHERE [Date] BETWEEN '{0}' AND '{1}'

