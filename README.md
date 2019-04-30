<img src="https://ispsession.io/images/Platipus3_Transparant_small.png" width="90" height="60" alt="logo"/> ISP Session for ASP.NET 4.x

# DemoISPSessionOnNet
Demonstrates how to implement ISP Session for ASP.NET 4.x and ISP Cache
Created at April 27,2019.
Using Visual Studio 2017 and a default 'new ASP.NET 4.x MVC project' without modifying the code.  
Only ISP Session has been added and necessary code to demonstrate how it works.

ISP Session is a product that can be found at https://ispsession.io

It allows you to have compatible session state with ASP.Net CORE up to 2.1 and higher (provided you use ISP Session there too).
In addition it gives you amazing caching ability using Redis. ISP Cache, minimizes roundtrip to Redis, 
while still giving the cached data using a JIT pattern.

This project, was a lot of fun creating. Please support it by bying a license so I can continue to improve it in future.

<a href="https://www.youtube.com/embed/lQzgJYQi-BI" target="_blank"><img src="http://img.youtube.com/vi/lQzgJYQi-BI/0.jpg" 
alt="Howto instruction on YouTube" width="240" height="180" border="10" /></a>

# roadmap for ISP Session.io
* Performance counters
* Command line tool to investigate session
* Integration with MemCached (as an choice between Redis).
* Pessimistic locking (Redlock) on Cache variables.