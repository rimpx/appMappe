# Windows Form Application - Mappe

## Description
This is a Windows Form application built using C# for displaying maps and managing locations. It allows users to search for locations, save them, calculate routes between them, and visualize saved routes.

## Features
- **Map Display:** Shows maps using various map providers such as OpenStreetMap, Google Maps, and Bing Maps.
- **Location Management:** Users can search for locations by name, save them with descriptions, and mark them as favorites or places to visit.
- **Route Calculation:** Calculates routes between saved locations and displays them on the map.
- **Data Persistence:** Locations and routes can be saved to and loaded from a JSON file.

## Installation
1. Clone the repository to your local machine.
2. Open the solution file (`Mappe.sln`) in Visual Studio.
3. Build the solution to ensure all dependencies are resolved.
4. Run the application.

## Usage
1. **Search for Locations:** Enter the name of a location and click "Cerca" to find it on the map.
2. **Save Locations:** Fill in the details of a location and click "Salva Posizione" to save it.
3. **Calculate Route:** Select start and end locations from the dropdowns and click "Calcola Percorso" to calculate the route between them.
4. **Manage Saved Locations:** View saved locations in the DataGridView and delete them if needed.
5. **Manage Saved Routes:** View saved routes in the DataGridView and delete them if needed.

## Dependencies
- **GMap.NET:** Library for displaying maps and routes.
- **Newtonsoft.Json:** Library for JSON serialization and deserialization.

## Contributing
Contributions are welcome! Feel free to open an issue or submit a pull request with any improvements or bug fixes.

## License
This project is licensed under the [MIT License](LICENSE).

