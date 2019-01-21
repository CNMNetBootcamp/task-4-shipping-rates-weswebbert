if a package weighs less than or equal to 2lbs, cost of shipping is $2
greater than 2 but less than 6, cost of shipping is $4
greater than 6lbs but less than 10, cost of shipping is $6
greater than 10, cost of shipping is $10

string cost = string.Empty;
Double pounds = 0.0;

//input
PUT "What is the weight of the package?"
GET Weight

//process
if (pounds <= 2) 
cost = "$2";
    
else if (pounds > 2 && pounds <= 6)
cost = "$4";
            
else if (pounds > 6 && pounds <= 10)
cost = "$6";
            
else if (pounds > 10)
cost = "$10";
           
else
cost = "$10";
            
//output
PUT "The cost of shipping will be " + cost