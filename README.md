nHealthcareDotGov
=================

.NET PCL API for playing with the HealthCare.gov API


Change log
----------

* 7/25/2013 11:01:06 AM by AD:   Initial release just to get it all on github and nuget. Works to retrieve articles only at the moment, but can easily expand to support the rest.

```C#
var news = await HealthcareGovRepository.GetArticles();
```