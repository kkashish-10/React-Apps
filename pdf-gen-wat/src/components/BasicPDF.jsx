import React from 'react'
import { Document, Page, Text, View, StyleSheet, PDFViewer } from '@react-pdf/renderer'


// create styles 
const styles = StyleSheet.create({
  page: {
    backgroundColor: 'white',
    // color: 'black'
  },
  section: {
    margin: 10,
    padding: 10
  },
  viewer: {
    width: window.innerWidth,
    height: window.innerHeight,
  },
});
//create document component 
const BasicPDF = () => {
  return (
    <PDFViewer>
      {/* Start of the document */}
      <Document>
        {/* render a single page */}
        <Page size={"A4"} style={} ></Page>
      </Document>
    </PDFViewer>
  )
}

export default BasicPDF