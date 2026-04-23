```mermaid
classDiagram
class Cell{
	-charge: float
	+Name: string
	+Charge: float
	+Level: 1 + Charge(int) / 40
	+Consume(): void
	+Restore(): void
	+ToString(): string
}
```