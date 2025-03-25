import { ThemeProvider } from "@mui/material/styles";
import { Box } from "@mui/material"; // ✅ Importação corrigida
import {
  createContext,
  useCallback,
  useContext,
  useMemo,
  useState,
  ReactNode, // ✅ Importação para tipagem do children
} from "react";
import { DarkTheme, LightTheme } from "./../themes";

// Interface para o contexto do tema
interface IThemeContextData {
  themeName: "light" | "dark";
  toggleTheme: () => void;
}

// Criando o contexto
const ThemeContext = createContext<IThemeContextData>({} as IThemeContextData);

// Hook personalizado para acessar o contexto
export const useAppThemeContext = () => {
  return useContext(ThemeContext);
};

// Definição correta da tipagem de props, incluindo `children`
interface IAppThemeProviderProps {
  children: ReactNode;
}

// Provedor do tema
export const AppThemeProvider: React.FC<IAppThemeProviderProps> = ({
  children,
}) => {
  const [themeName, setThemeName] = useState<"light" | "dark">("light");

  // Alterna entre tema claro e escuro
  const toggleTheme = useCallback(() => {
    setThemeName((oldThemeName) =>
      oldThemeName === "light" ? "dark" : "light"
    );
  }, []);

  // Define o tema com base no estado atual
  const theme = useMemo(() => {
    return themeName === "light" ? LightTheme : DarkTheme;
  }, [themeName]);

  return (
    <ThemeContext.Provider value={{ themeName, toggleTheme }}>
      <ThemeProvider theme={theme}>
        {/* Aplicando o fundo do tema */}
        <Box
          width="100vw"
          height="100vh"
          bgcolor={theme.palette.background.default}
        >
          {children}
        </Box>
      </ThemeProvider>
    </ThemeContext.Provider>
  );
};
