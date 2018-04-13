select Fund, Org, Code, BOC, sum(Amount) as BocLevel
from P7
Group By Fund, Org, Code, BOC;