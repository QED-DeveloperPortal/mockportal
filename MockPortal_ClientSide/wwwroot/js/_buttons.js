const converted_buttons = {
    ".btn": {
      display: "inline-block",
      marginBottom: "0.25em",
      padding: "0.5em 1em",
      fontFamily: "$sans-serif-font-family",
      fontSize: "1rem",
      fontWeight: "bold",
      textAlign: "center",
      textDecoration: "none",
      borderWidth: "0",
      borderRadius: "$border-radius",
      cursor: "pointer",
      ".icon": { marginRight: "0.5em" },
      ".icon + .hidden": { marginLeft: "-0.5em" },
      "&--block": {
        display: "block",
        width: "100%",
        "+ .btn--block": { marginTop: "0.25em" }
      },
      "&--disabled": {
        pointerEvents: "none",
        cursor: "not-allowed",
        filter: "alpha(opacity=65)",
        boxShadow: "none",
        opacity: 0.65
      },
      "&--x-large": { fontSize: "2rem" },
      "&--large": { fontSize: "1.5rem" }
    }
  }
  