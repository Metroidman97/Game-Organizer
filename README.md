# Game-Organizer

Table of Contents:

[Overview](https://github.com/Metroidman97/Game-Organizer/blob/main/README.md#overview)  
[Solution Architecture Diagram](https://github.com/Metroidman97/Game-Organizer/blob/main/README.md#solution-architecture-diagram)  
[Wireframe Diagrams](https://github.com/Metroidman97/Game-Organizer/blob/main/README.md#wireframe-diagrams)  
[User Stories](https://github.com/Metroidman97/Game-Organizer/blob/main/README.md#user-stories)  
[Initial Use Cases](https://github.com/Metroidman97/Game-Organizer/blob/main/README.md#initial-use-cases)  
[Use Case Diagram](https://github.com/Metroidman97/Game-Organizer/blob/main/README.md#use-case-diagram)  
[Project Requirements Table](https://github.com/Metroidman97/Game-Organizer/blob/main/README.md#project-requirements-table)  
[ERD](https://github.com/Metroidman97/Game-Organizer/blob/main/README.md#erd)  
[UML Diagram](https://github.com/Metroidman97/Game-Organizer/blob/main/README.md#uml-diagram)

## Overview

The Game Organizer is intended to be an easy and convenient way for people to organize their game
collections. Based on the Lego database site Brickset, the Game Organizer would allow users to browse
through a database containing several console games from across several years, and they would be able
to tag which games they own and which ones they want. The games stored in the database would
contain several parameters users can filter their search by, to make finding games much easier. Along
with potential forum features, or just simply linking to dedicated discord servers, the site would allow
players to organize their collections and connect with others with similar interests.

## Solution Architecture Diagram

![alt text](images./Solution%20architecture%20diagram.png "Solution Architecture Diagram")

## Wireframe Diagrams

Home Page Wireframe Diagram
![alt text](images./Game%20Organizer%20Wireframe%20Homepage.png "Home Page Wireframe")

Search Page Wireframe Diagram
![alt text](images./Game%20Organizer%20Wireframe%20Search%20Page.png "Search Page Wireframe")

## User Stories

As a fan of a specific series  
I need to search for games specifically in that series  
So that I can find games in that series I might not have played  

As a gamer with a large collection  
I need to tag games in the database that I own  
So that I can see just how many games I have  

As a fan of certain games with few friends  
I need see what kinds of games other people like  
So that I can find people who like the kinds of games I like and can connect with  

As a new user  
I need to be able to create an account and log in  
So that I can start listing the games I own  

As a database manager  
I need to be able to insert new games into the database  
So that the database is more complete and users can include all games in their collection  

## Initial Use Cases

[link to use cases](documents/Use%20Cases.docx)  
Will have to download file

## Use Case Diagram

![alt text](images./Use%20Case%20Diagram.png "Use case diagram")

## Project Requirements Table

|ID|Requirement|Description|
|---|---|---|
|001|Login/Logout|The software will give users the ability to log into/sign out of their account|
|002|Tag owned/wanted games|The software will give users the ability to tag games in the database that they own/want|
|003|Search database|The software will give users the ability to search through the contents of the database|
|004|Filter search|The software will give users the ability to filter their searches by premade parameters|
|005|Modify database|The software will give authorized users the ability to modify the database (inset/update/delete entries) via a DBMS|
|006|Search profiles|The software will give users the ability to view the profiles and owned/wanted lists of other users|

## ERD

![alt text](images./Chen%20ERD.png "Entity relation diagram")

## UML Diagram

![alt text](images./UML%20Class%20diagram.png "UML Class Diagram")
