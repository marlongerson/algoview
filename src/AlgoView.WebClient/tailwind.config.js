module.exports = {
  purge: {
    enabled: true,
    content: ["./**/*.html", "./**/*.razor"],
  },
  darkMode: false,
  theme: {
    extend: {},
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
