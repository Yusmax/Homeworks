// Задание 1
var name = prompt("What's your name:");
alert("Salam, " + name);

// Задание 2
var currentYear = new Date().getFullYear();
var birthYear = parseInt(prompt("In what year were you born:"));
var age = currentYear - birthYear;
alert("Senin " + age + "yashin var");

// Задание 3
var sideLength = parseFloat(prompt("Enter the side length of the square:"));
var perimeter = 4 * sideLength;
alert("The perimeter of the square is: " + perimeter);

// Задание 4
var radius = parseFloat(prompt("Enter the radius of the circle:"));
var area = Math.PI * Math.pow(radius, 2);
alert("The area of the circle is " + area);

// Задание 5
var distance = parseFloat(prompt("Enter the distance between cities:"));
var hours = parseFloat(prompt("Enter the number of hours for the trip:"));
var speed = distance / hours;
alert("Need to move with speed " + speed);
