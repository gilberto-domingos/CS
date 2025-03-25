import { CssBaseline } from "@mui/material";
import { AppRoutes } from "./routes/routes";
import { AppThemeProvider } from "./shared/contexts";

export function App() {
  return (
    <AppThemeProvider>
      <CssBaseline />
      <AppRoutes />
    </AppThemeProvider>
  );
}

export default App;
