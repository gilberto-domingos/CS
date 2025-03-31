import React from "react";
import { Button } from "@mui/material";

interface ButtonProps {
  label: string;
  variant?: "primary" | "secondary" | "danger";
  onClick?: () => void;
}

const Buttons: React.FC<ButtonProps> = ({
  label,
  variant = "primary",
  onClick,
}) => {
  const getColor = () => {
    switch (variant) {
      case "secondary":
        return "secondary";
      case "danger":
        return "error";
      default:
        return "primary";
    }
  };

  return (
    <Button variant="contained" color={getColor()} onClick={onClick}>
      {label}
    </Button>
  );
};

export default Buttons;
