Le push sur master et develop n'est pas autorisé, chaque developpement doit être effectué sur une branche du type :
* release/#n-nom-du-ticket
* feature/#n-nom-du-ticket
* hotfix/#n-nom-du-bug

Une fois la tâche finie, crée une merge request qui sera testé et validé par @shked0wn.

Ceci dans le but de garder un code fonctionnel, propre et dans une continuité de la logique implémenté au début.

La merge request devra porter le nom de la version :

* Incrementer de 1 si nouvelle realease et mettre à 0 le 2ème et 3ème chiffre
* Incrémenter de 0.1 si nouvelle feature et mettre à 0 le 3ème chiffre
* Incrémenter de 0.0.1 si hotfix

Exemple : Version 0.5


Bonnes pratiques :

* Préférer mettre les éléments de layout dans le XAML plutot que dans le code.
* Toujours respecter les nom de classes et leurs architectures (Models, Views, Services, ...)
* Toujours essayer de mutualiser le code au maximum.
* Une bibliothèque est présente dans la classe Wineot.xaml avec la définitions des couleurs utilisées dans l'app
Pour les utiliser voici un exemple : {StaticResource DarkPrimaryColor}.
Si besoin d'ajouter un couleur ou une variable ou autre merci de l'ajouter dans cette bibliothèque.