import { CssBaseline } from "@mui/material";
import { AppRoutes } from "./routes/routes";
import { AppThemeProvider } from "./shared/contexts";
import { SideMenu } from "./shared/components/side-menu";

export function App() {
  return (
    <AppThemeProvider>
      <CssBaseline />
      <SideMenu>
        <AppRoutes />
      </SideMenu>
    </AppThemeProvider>
  );
}

export default App;
