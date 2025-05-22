# TaskManagerApp

## Descriere

TaskManagerApp este o aplicație web simplă dezvoltată cu ASP.NET MVC și Entity Framework (Code First), care permite gestionarea eficientă a task-urilor personale sau de echipă.

Aplicația oferă funcționalități esențiale pentru organizarea și monitorizarea task-urilor, fiind ideală pentru utilizatorii care doresc o soluție rapidă și ușor de utilizat pentru managementul activităților zilnice.

---

## Funcționalități principale

- Adăugarea task-urilor cu detalii: titlu, descriere, dată limită și stare (ToDo / In Progress / Done).
- Vizualizarea listei de task-uri existente.
- Filtrarea task-urilor după stare pentru o gestionare mai eficientă.
- Marcare task-uri ca „Done” pentru a urmări progresul.
- Opțional: salvarea și încărcarea task-urilor dintr-un fișier pentru backup local.

---

## Tehnologii utilizate

- **ASP.NET MVC** — pentru arhitectura aplicației și interfața web.
- **Entity Framework Core (Code First)** — pentru gestionarea bazei de date și modelarea datelor.
- **SQL Server LocalDB** (sau altă bază de date compatibilă) — ca sistem de stocare.
- **Bootstrap 5** (opțional) — pentru design responsiv și UI modern.
- **Git & GitHub** — pentru controlul versiunilor și colaborare.

---

## Structura proiectului

- **Controllers** — gestionează logica de interacțiune între utilizator și date.
- **Models** — conține clasele pentru entitățile aplicației (ex: Task).
- **Views** — interfețele utilizator (pagini web).
- **Data** — conține contextul bazei de date (DbContext).
- **Services - conține business logic-ul 
- **wwwroot** — resurse statice (CSS, JS, imagini).
- **appsettings.json** — configurări aplicație (conexiune bazei de date, etc).

---


