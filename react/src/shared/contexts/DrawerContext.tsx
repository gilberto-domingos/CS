import {
  createContext,
  useCallback,
  useContext,
  useState,
  ReactNode,
} from "react";

interface IDrawerContextData {
  isDrawerOpen: boolean;
  toggleDrawerOpen: () => void;
}

const DrawerContext = createContext<IDrawerContextData>(
  {} as IDrawerContextData
);

export const useDrawerContext = () => {
  return useContext(DrawerContext);
};

interface IAppThemeProviderProps {
  children: ReactNode;
}

export const DrawerProvider: React.FC<IAppThemeProviderProps> = ({
  children,
}) => {
  const [isDrawerOpen, setIsDrawerOpen] = useState(false);

  const toggleDrawerOpen = useCallback(() => {
    setIsDrawerOpen((oldDrawerOpen) => !oldDrawerOpen);
  }, []);

  return (
    <DrawerContext.Provider value={{ isDrawerOpen, toggleDrawerOpen }}>
      {children}
    </DrawerContext.Provider>
  );
};
