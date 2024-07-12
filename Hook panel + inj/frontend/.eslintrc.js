module.exports = {
    "env": {
        "browser": true, "es2021": true, "node": true,
    }, "extends": ["plugin:react/recommended", "google"], "parser": "@typescript-eslint/parser", "parserOptions": {
        "ecmaFeatures": {
            "jsx": true,
        }, "ecmaVersion": "latest", "sourceType": "module",
    }, "plugins": ["react", "@typescript-eslint", "unused-imports"], "rules": {
        "camelcase": "off",
        "require-jsdoc": 0,
        "semi": ["error", "always"],
        "quotes": ["error", "double"],
        "indent": ["error", 4],
        "max-len": [2, 160, 4, {
            "ignoreUrls": true,
        }], /* "linebreak-style": ["error", process.platform === "win32" ? "windows" : "unix"],*/
        "unused-imports/no-unused-imports": 2,
        "no-invalid-this": 0,
    }, "settings": {
        "react": {
            "pragma": "React", "version": "17.0.2",
        },
    },
};
