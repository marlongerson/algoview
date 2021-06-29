module.exports = {
  purge: {
    enabled: true,
    content: ["./**/*.html", "./**/*.razor"],
  },
  darkMode: false,
  theme: {
    extend: {
      transitionProperty: {
        width: 'width'
      }
    },
    fontFamily: {
      'body': ['Inter', 'arial', 'sans-serif'],
      'sans': ['Inter', 'arial', 'sans-serif'],
    }
  },
  variants: {
    extend: {},
  },
  plugins: [],
};
