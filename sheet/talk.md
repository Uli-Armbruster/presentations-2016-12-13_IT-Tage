#Pr�sentation
*	Warum
**	Angst vor �nderungen / Erweiterungen
**	Aufeinandertreffen mit Black Boxes
**	K�nnen wir das noch schnell hinterher schieben?
**	Sprints => Deliverables
*	Wie
**	SOLID im Schnelldurchlauf
**	Alles f�hrt zu OCP
*	Was
**	Real Code Application aus meinen Schulung
**	Vortrag ist so aufgebaut, dass kontinuierlich Fragen gestellt werden k�nnen und ggf. einfach hinten Beispiele wegfallen

#Code
*	Ablauf Applikation zeigen
*	Trennung von Implementierung und Kontrakten
**	Keine Contracts.dll als Gott Assembly
**	Interne vs. Externe Kontrakte vs. Keine Kontrakte
**	Kontrakt = Interface / Abstract / DTO
**	Ziel: Assemblies austauschen oder alternative Assemblies mit weiteren 
*	Bootstrapping
**	IoC Initialisierung als Teil des Bootstrappings
**	Konventionsbasierte Registrierungen
**	Installer pro Projekt
**	Know your tools: Daemons
*	Single Entry Point
**	Kein Service Location => Integrationstests
**	Scoped
*	Sonstiges
**	Know your tools: Collections
**	Rx als gutes Zusammenspiel mit Castle.Windsor
**	Observables
**	Message Broker
**	Window Opener