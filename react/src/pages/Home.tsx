import { Link } from "react-router-dom";
import Buttons from "../shared/components/Buttons";
import { useAppThemeContext } from "../shared/contexts";
import "../styles/home.css";

export const Home = () => {
  const { toggleTheme } = useAppThemeContext();

  return (
    <div className="home-container">
      <h1>Bem-vindo</h1>

      <Buttons
        label="Botão Primário"
        variant="primary"
        onClick={() => alert("Primário")}
      />
      <Buttons
        label="Botão Secundário"
        variant="secondary"
        onClick={() => alert("Secundário")}
      />
      <Buttons
        label="Botão de Perigo"
        variant="danger"
        onClick={() => alert("Erro!")}
      />

      <div className="home-button-container">
        <Buttons
          label="Alternar Tema"
          variant="secondary"
          onClick={toggleTheme}
        />
      </div>

      <Link to="/home2" className="home-link">
        Ir para Home2
      </Link>
    </div>
  );
};
