"""
Marta Polishchuk
301432299
Assignment 3
COMP 120 SEC 402
"""

# Week 6 Exercise 1
# 1. Create 3 favorite things about you using multiline string.

favourite_things = 'My Ukrainian culture'\
                    'My dog'\
                      'My various hobbies'

# 2. Using variables in string print - student full details. (firstname, lastname, address)
first_name = "Marta"
last_name ="Polishchuk"
address = "123 Python St"

student_full_details = f"{first_name} {last_name} {address}"
print(student_full_details)






# Week 6 Exercise 2
# Create a list of agile software. Insert the values, delete one item from the list, use slicing and display the list of software's.
agile_software = [ ]
agile_software.insert(0,'Jira')
agile_software.insert(1,'Scrum')
agile_software.insert(2,'Miro')
agile_software.insert(3,'GitLab')
agile_software.insert(4,'Wrike')
print(agile_software)

del agile_software[4]
print(agile_software)

last_two = agile_software[-2:]
print(last_two)
middle_two = agile_software[1:3]
print(middle_two)

# Week 6 Exercise 3
# Start with the list by printing three course’s name like comp100,comp120,comp213. Print a message saying that you are enrolled in that course. The text of each message should be the same, but each message should be personalized with the course ’s name. Append a new course GNET.
courses = ['comp100', 'comp120', 'comp213']
for item in courses:
  print(item)

print("You are enrolled in " + (courses[0]) + ".")
print("You are enrolled in " + (courses[1]) + ".")
print("You are enrolled in " + (courses[2]) + ".")

courses.append('GNET')
print(courses)


# Week 8 Exercise 1
# Use the following dictionary and answer the questions:

favorite_languages = {
  'jen': 'HTML',
  'sarah': 'c',
  'edward': 'ruby',
  'phil': 'C#',
}
# 1. Change the value from C# to Python for the key phil 
favorite_languages['phil'] = 'Python'
print(favorite_languages)
# 2. Add an item in the dictionary 
favorite_languages['marta'] = 'CSS'
print(favorite_languages)
# 3. Remove an item from the dictionary
del favorite_languages['marta']
print(favorite_languages)
# 4. List all the values in the dictionary 
languages = favorite_languages.values() 
print(languages)

# Week 8 Exercise 2
# Create a python dictionary called student. Include student name, age, subject, semester, grade and lab keys. Include the value for each key accordingly. Display keys separately and values separately in the print statement.
student = {
  "name": "Marta",
  "age": 26,
  "subject": "Software Engineering",
  "semester": 1,
  "grade": "A",
  "lab": "Python Dictionaries"
}

print("keys:")
for key in student.keys():
  print(key)

print("Values:")
for value in student.values():
  print(value)

# Week 9 Exercise 1
# Write a program in python using if condition. Input the temperature (user input). Check if the temperature is less than 98 display the result as cold. Otherwise if the temperature more than 98, display the result as Hot. otherwise display them as normal. 
temp=int(input("Enter temperature:"))

if(temp < 98):
    print("cold")
elif(temp > 98):
    print("hot")
else:
    print("normal")


# Week 9 Exercise 2
# Program to iterate agile values through a list using indexing. Create the following agile values in list. Use for loop and iterate over the list:

agile_values = ['Individuals and interactions', 'Working software ', 'Customer collaboration ','Responding to change']

for value in range(len(agile_values)):
    print(f" {value+1}: {agile_values[value]}")

# Week 10 Exercise 1
# Create a function called team_collaboration(). Pass two team collaboration software names as the arguments. 
#The function should print "I use ------- software for team collaboration "
def team_collaboration(Jira, Miro):
  print(f"I use {Jira} software for team collaboration.")
  print(f"I also use {Miro} software for team collaboration.")

team_collaboration("Jira","Miro")

# Week 10 Exercise 2
# Create a function called project() that store project_id globally and locally. Call the function and display both the id's. 
#Print the statement as:
  #"My global project id is :"
  #"My internal project id is :"
def project():
  global project_id 
  project_id = "1234"
  local_project_id = "4321"

  print("My global project ID is:", project_id)
  print("My local project ID is:", local_project_id)

project()

# Week 11: File Handling Exercise 1 
# Create a text file called  pi_digits.txt:
f = open("pi_digits.txt", "a") 
f.write("3.1415926535 8979323846 2643383279")
f.close()
#1. read the file
f=open("pi_digits.txt", "r")
print(f.read())

# use readline method
# Write a number to the existing file
f = open("pi_digits.txt", "w") 
f.write("123456")
f.close()

f = open("pi_digits.txt", "r")
print(f.readline())
f.close()

# Week 11: Modules(Importing Libraries) Exercise 1
#Import the correct library and print a calendar for your project. Print October month calendar of this year. 
#x = datetime.datetime.now()
#print(x)
import calendar
import datetime

year = datetime.datetime.now().year
print(calendar.month(year,10))

# Week 11: Modules(Importing Libraries) Exercise 2
#Use 5 Functions in Python Math Module and print the results:
import math
print(f'The value of pi is approximately {math.pi:.6f}.')
print(f'The factorial of 4 is {math.factorial(4)}.')
print(f'The square root of 49 is: {math.sqrt(49)}.')
print(f'The logarithm base 10 of 50 is: {math.log10(50)}.')
print(f'The absolute value of -35 is: {math.fabs(-10)}.')

# Week 11: Modules(Importing Libraries) Exercise 3
#Using OSmodule, explore the following functions and execute the command:
import os
#1. Write a command to create a new directory using OS Library:
directory_name = "new_directory"
os.mkdir(directory_name)
#2. Write a command to delete the existing file:
os.remove(pi_digits.txt)
f=open("pi_digits.txt", "r")
print(f.read())