git init
touch .gitignore
touch readme.md
code .


#Création de l'espace de travail
## Création d'un projet console
Depuis le dossier Isen.DotNet:
mkdir Isen.DotNet.ConsoleApp
cd Isen.DotNet.ConsoleApp
dotnet new console 
dotnet run

## Commit Git
Repository Remote
Depuis la racine du projet:
git status
git add .
Ils sont maintenant suivis : git status 
Commit : (ajout à l'historique local)  git commit -m "Message de commit"
git commit -a -m "updated readme"

## Création d'un projet librairie
Depuis le dossier ISEN.DotNet
mkdir ISEN.DotNet.Library
cd ISN.DotNet.Library
dotnet new classlib
dotnet run

##Ajout de la lib en réf du projet console
Depuis le dossier du projet Console : 
dotnet add reference
..\ISEN.DotNet.Library\ISEN.DotNet.Library.csproj
Coder la classe Hello.
Dans le Program.cs, ajouter le using et appeler la classe Hello.

##Creatio d'une solution et ajout de projet
Depuis le dossier racine
Créer le fichier solution : dotnet new sln
Ajouter le projet lib : 
dotnet sln add ISEN.DotNet.Library\ISEN.DotNet.Library.csproj
Ajouter le projet console :
dotnet sln add ISEN.DotNet.ConsoleApp\ISEN.DotNet.ConsoleApp.csproj

##Commit git
git add .
git commit -m "Ajout du dossier sln solution"

##Ajout d'un projet de test
TDD = Test Driven Development
Depuis le dossier racine : 
mkdir ISEN.DotNet.Tests 
Puis : cd ISEN.DotNet.Tests
Connaitre une liste des infos de cmd : dotnet new -h
Créer le projet de Test :
dotnet new xunit
Ajouter ce projet à la solution sln : 
dotnet sln add .\ISEN.DotNet.Tests\ISEN.DotNet.Tests.csproj
Depuis le dossier du projet de tests :
dotnet add reference ..\ISEN.DotNet.Library\ISEN.DotNet.Library.csproj
Commit git (penser à se remettre dans le dossier racine)
git add .
git commit -m "petit message"
