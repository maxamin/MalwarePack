/**
 * Copyright (c) 2017-present, Facebook, Inc.
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

const React = require('react');

class Footer extends React.Component {
  docUrl(doc, language) {
    const baseUrl = this.props.config.baseUrl;
    const docsUrl = this.props.config.docsUrl;
    const docsPart = `${docsUrl ? `${docsUrl}/` : ''}`;
    const langPart = `${language ? `${language}/` : ''}`;
    return `${baseUrl}${docsPart}${langPart}${doc}`;
  }

  pageUrl(doc, language) {
    const baseUrl = this.props.config.baseUrl;
    return baseUrl + (language ? `${language}/` : '') + doc;
  }

  render() {
    return (
      <footer className="nav-footer" id="footer"   >
        <a
          href="https://concord.ua/"
          target="_blank"
          rel="noreferrer noopener"
          className="fbOpenSource" style={{display: 'flex', justifyContent: 'center'}} >
          <img
            src={`${this.props.config.baseUrl}img/footer-concord-logo.png`}
            alt="Concord"
            width="65"
            height="45"
          />
        </a>
        <section className="copyright" style={{display: 'flex', justifyContent: 'center'}}>{this.props.config.copyright}</section>
      </footer>
    );
  }
}

module.exports = Footer;
