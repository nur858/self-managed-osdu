/*
 * self-managed-osdu
 * Rest API Documentation for Self Managed OSDU
 *
 * OpenAPI spec version: 0.11.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.client.model.SearchPoint;
import java.io.IOException;

/**
 * A spatial filter criteria to allow to filter documents based on a point location within a bounding box.
 */
@ApiModel(description = "A spatial filter criteria to allow to filter documents based on a point location within a bounding box.")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2022-01-06T19:58:30.495Z")
public class SearchByBoundingBox {
  @SerializedName("topLeft")
  private SearchPoint topLeft = null;

  @SerializedName("bottomRight")
  private SearchPoint bottomRight = null;

  public SearchByBoundingBox topLeft(SearchPoint topLeft) {
    this.topLeft = topLeft;
    return this;
  }

   /**
   * Get topLeft
   * @return topLeft
  **/
  @ApiModelProperty(required = true, value = "")
  public SearchPoint getTopLeft() {
    return topLeft;
  }

  public void setTopLeft(SearchPoint topLeft) {
    this.topLeft = topLeft;
  }

  public SearchByBoundingBox bottomRight(SearchPoint bottomRight) {
    this.bottomRight = bottomRight;
    return this;
  }

   /**
   * Get bottomRight
   * @return bottomRight
  **/
  @ApiModelProperty(required = true, value = "")
  public SearchPoint getBottomRight() {
    return bottomRight;
  }

  public void setBottomRight(SearchPoint bottomRight) {
    this.bottomRight = bottomRight;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SearchByBoundingBox searchByBoundingBox = (SearchByBoundingBox) o;
    return Objects.equals(this.topLeft, searchByBoundingBox.topLeft) &&
        Objects.equals(this.bottomRight, searchByBoundingBox.bottomRight);
  }

  @Override
  public int hashCode() {
    return Objects.hash(topLeft, bottomRight);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SearchByBoundingBox {\n");
    
    sb.append("    topLeft: ").append(toIndentedString(topLeft)).append("\n");
    sb.append("    bottomRight: ").append(toIndentedString(bottomRight)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

