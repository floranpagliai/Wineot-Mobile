Le push sur master et develop n'est pas autorisé, chaque developpement doit être effectué sur une branche du type :
* feature/#n-nom-du-ticket
* hotfix/#n-nom-du-bug

Une fois la tâches fini, crée une merge request qui sera testé et validé par @shked0wn.
Ceci dans le but de garder un code fonctionnel, propre et dans une continuité de la logique implémenté au début.

Bonnes pratiques :

* Préférer mettre les éléments de layout dans le XAML plutot que dans le code.
* Toujours respecter les nom de classes et leurs architectures (Models, Views, Services, ...)
* Toujours essayer de mutualiser le code au maximum.
* Une bibliothèque est présente dans la classe Wineot.xaml avec la définitions des couleurs utilisées dans l'app
Pour les utiliser voici un exemple : {StaticResource DarkPrimaryColor}.
Si besoin d'ajouter un couleur ou une variable ou autre merci de l'ajouter dans cette bibliothèque.