import { Link } from "react-router-dom";
import Buttons from "../shared/components/button/Buttons";
import { useAppThemeContext } from "../shared/contexts";
import "../styles/home.css";

export const Home = () => {
  const { toggleTheme } = useAppThemeContext();

  return (
    <div className="home-container">
      <div className="home-button-container">
        <Buttons
          label="Alternar Tema"
          variant="secondary"
          onClick={toggleTheme}
        />
      </div>
    </div>
  );
};
