import { ThemeProvider } from "@mui/material/styles";
import { CssBaseline } from "@mui/material";
import { LightTheme } from "./shared/themes";
import { AppRoutes } from "./routes/routes";

export function App() {
  return (
    <ThemeProvider theme={LightTheme}>
      <CssBaseline />
      <AppRoutes />
    </ThemeProvider>
  );
}

export default App;
