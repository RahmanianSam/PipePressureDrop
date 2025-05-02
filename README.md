
# PipePressureDrop – Multiphase Pressure Drop Simulation Tool

A modular Windows desktop application developed in C# to simulate pressure drop in pipelines transporting multiphase fluids (oil, gas, water) using black oil PVT correlations under homogeneous flow assumptions. The application supports segment-based pressure calculations, unit switching, and GUI-based input/output.

---

## 🚀 Features

- **Black Oil Correlation Engine**
  - Implements black oil PVT relationships for Rs, Bo, Bg, and fluid densities.
  - Assumes no-slip (homogeneous) flow for mixture property calculations.

- **Segmented Pipe System Simulation**
  - Computes pressure drop across multiple pipe segments, aggregating results.
  - Displays pressure and Reynolds number profiles along the pipe length.

- **Scalable Object-Oriented Design**
  - Current implementation uses concrete classes such as `FluidProperties` and `PressureDropModel`.
  - The design can be extended following the UML architecture, introducing abstract base classes (e.g., `FluidPropertiesBase`, `PipePressureModelBase`) to support multiple EOS models and correlation methods.

- **Windows Forms GUI**
  - Interactive interface for input, file loading, and visual output.
  - Dynamic plots of pressure and Reynolds profiles.
  - Toggle between Field and SI unit systems.

- **File-Based Input and Logging**
  - Users can input flow conditions and pipe parameters through structured files.
  - Simulation log includes per-segment pressure outputs and unit details.

---

## 📊 Fluid Modeling Assumptions

The simulator uses a **homogeneous flow model**, where:
- All phases (oil, water, gas) are assumed to move at the same velocity.
- No phase slip is considered.
- Mixture density and viscosity are calculated based on weighted averages.
- Friction factor is evaluated using the correlation:  
  `f = 0.0056 + 0.5 × Re^(-0.32)`

---

## 🧱 Architecture Overview

The project follows a component-oriented structure. While the current implementation uses specific models, the system is designed for future extensibility as outlined in the UML below:

```
PressureDropModelBase
├── PipePressureModelBase
│   ├── SimplePipePressureDropModel
│   └── AdvancedPipePressureDropModel
├── FluidPropertiesBase
│   ├── SimpleBlackOilFluidProperties
│   └── EOSFluidProperties
└── FacilityObjects
    ├── Pipe
    ├── Valve
    └── Pump
```

This layout supports plugging in different physical models without modifying core logic.

---

## 📷 Screenshots

**1. GUI Overview with Pressure Profile (SI Units)**  
![image](https://github.com/user-attachments/assets/61b104f7-99f3-4fe1-805a-4c95f486c935)


**2. GUI with Field Units and Segment Input**  
![image](https://github.com/user-attachments/assets/06630bbf-0107-40ba-8031-ca6277dafae5)


**3. UML Architecture for Extendability**  
![image](https://github.com/user-attachments/assets/ed4a0a9d-0ddc-417a-ab10-a9860e6babcd)


---

## 🛠️ Getting Started

1. Clone the repository:  
   ```bash
   git clone https://github.com/RahmanianSam/PipePressureDrop.git
   ```

2. Open the solution in Visual Studio.

3. Build the project and run the GUI application.

4. Input parameters manually or load from file. Choose unit system, and click "Calculate Outlet Pressure" to run the simulation.

---

## 👤 Author

**Meysam Rahmanian**  
📧 rahmanian.s.meysam@gmail.com  
🔗 [LinkedIn](https://www.linkedin.com/in/rahmaniansam)

---

