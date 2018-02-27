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