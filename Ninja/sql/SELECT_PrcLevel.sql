select Fund, Org, Code, sum(Amount) as PrcLevel
from P7
where BOC != '17'
Group By Fund, Org, Code;